/// <reference path="UI.js" />
/// <reference path="jquery-2.0.2.js" />
/// <reference path="Persister.js" />
/// <reference path="q.js" />
/// <reference path="classical-class-create-inherit.js" />

var Controller = (function (selector) {

    var MainController = Class.create({
        init: function (selector) {
            var persisterMy = new Persister;
            this.persister = persisterMy.mainPersister('http://localhost:22954/api/');
            this.selector = selector;
            this.openGamesState;
            this.activeGamesState;

            this._isSelected = false;
            this._nextPoss;
            this._currGameData;
            this._playerInTurn;
        },
        loadUI: function () {
            if (this.persister.isLoggedin()) {
                this.loadGameUI(this.selector);
            }
            else {
                this.loadInputUI(this.selector);
            }
            this.addEventHendlersUI(this.selector);

            return this;
        },
        loadInputUI: function () {
            var inputForms = UI.getInputForms();

            $(this.selector).html(inputForms);
        },
        loadGameUI: function () {
            var gameUI = UI.getGameUI();
            $(this.selector).html(gameUI);

            this.loadAllMessages();
            setInterval(function () {
                self.loadUnreadMessages();
            }, 2000);

            var self = this;
            this.persister.user.score()
                .then(function (data) {
                    for (var user in data) {
                        if (data[user].nickname == localStorage.getItem('nickname')) {
                            return data[user].score;
                        }
                    }
                })
            .then(function (score) {
                $('#wellcome').text(localStorage.getItem("nickname"));
                $('#score span').text(score);
            })
            .then(function () {
                self.loadActiveGameUI('#activeGames');
                setInterval(function () {
                    self.loadActiveGameUI('#activeGames');
                }, 2000);
            })
            .then(function () {
                self.loadOpenGameUI('#openGames');
                setInterval(function () {
                    self.loadOpenGameUI('#openGames');
                }, 5000);

            })
            .then(function () {
                self.loadMakeGameUI('#createGame');
            }).done()
        },
        loadAllMessages: function (selector) {
            this.persister.message.all()
                .then(function (messages) {
                    for (var message in messages) {
                        var li = $('<li />');
                        li.text(messages[message].text);
                        $('#messagesList').prepend(li);
                    }
                })
        },
        loadUnreadMessages: function (selector) {
            var self = this;
            this.persister.message.unread()
                .then(function (messages) {
                    if (messages.length > self.messagesState) {
                        for (var message in messages) {
                            var li = $('<li />');
                            li.text(messages[message].text);
                            $('#messagesList').prepend(li);
                        }
                        self.messagesState = messages.length;
                    }
                })
        },
        loadActiveGameUI: function (selector) {
            var self = this;
            this.persister.game.active()
                    .then(function (games) {
                        var activeGames = UI.getActiveGames(games);
                        if (self.activeGamesState != activeGames) {
                            $("#activeGames").html(activeGames);
                            self.activeGamesState = activeGames;
                            for (game in games) {
                                //console.log(games[game]);
                                if (games[game].creator == localStorage.getItem('nickname') && games[game].status == 'full') {
                                    var elementId = games[game].id;
                                    var button = $('<button />');
                                    button.text('start');
                                    button.attr('id', elementId);
                                    $('[data-game-id="' + elementId + '"]').after(button);
                                }
                                else if (games[game].status == 'in-progress') {
                                    var elementId = games[game].id;
                                    var div = $('<div />');
                                    div.attr('class', 'in-progress');
                                    $('[data-game-id="' + elementId + '"]').after(div);
                                }
                                else {
                                    $('<button />').remove();
                                }
                            }
                        }
                    });
        },
        loadFieldState: function (gameID) {
            var self = this;
            var field = this.persister.game.field(gameID);
            field.then(function (data) {
                var battleField = UI.getGameField(data.blue.nickname, data.red.nickname);
                $('#battleField').html(battleField);
                self.fieldState = data;
                self._currGameData = data;

                var blueUnits = data.blue.units;
                for (unit in blueUnits) {
                    if (blueUnits[unit].type == 'warrior') {
                        var possitionX = blueUnits[unit].position.x;
                        var possitionY = blueUnits[unit].position.y;
                        var unitId = blueUnits[unit].id;
                        var selectField = ('section' + possitionX) + possitionY;
                        $('#' + selectField).addClass('blueWarrior');
                        $('#' + selectField).addClass('blue');

                        if (blueUnits[unit].mode == 'defend') {
                            $('#' + selectField).text('W-D');
                        }
                        else {
                            $('#' + selectField).text('W-A');
                        }
                        $('#' + selectField).attr('data-unit-id', unitId);
                    }
                }

                for (unit in blueUnits) {
                    if (blueUnits[unit].type == 'ranger') {
                        var possitionX = blueUnits[unit].position.x;
                        var possitionY = blueUnits[unit].position.y;
                        var selectField = ('section' + possitionX) + possitionY;
                        var unitId = blueUnits[unit].id;
                        $('#' + selectField).addClass('blueRanger');
                        $('#' + selectField).addClass('blue');
                        if (blueUnits[unit].mode == 'defend') {
                            $('#' + selectField).text('R-D');
                        }
                        else {
                            $('#' + selectField).text('R-A');
                        }
                        $('#' + selectField).attr('data-unit-id', unitId);
                    }
                }

                var redUnits = data.red.units;
                for (unit in redUnits) {
                    if (redUnits[unit].type == 'warrior') {
                        var possitionX = redUnits[unit].position.x;
                        var possitionY = redUnits[unit].position.y;
                        var unitId = redUnits[unit].id;
                        var selectField = ('section' + possitionX) + possitionY;
                        $('#' + selectField).addClass('redWarrior');
                        $('#' + selectField).addClass('red');
                        if (redUnits[unit].mode == 'defend') {
                            $('#' + selectField).text('W-D');
                        }
                        else {
                            $('#' + selectField).text('W-A');
                        }
                        $('#' + selectField).attr('data-unit-id', unitId);
                    }
                }

                for (unit in redUnits) {
                    if (redUnits[unit].type == 'ranger') {
                        var possitionX = redUnits[unit].position.x;
                        var possitionY = redUnits[unit].position.y;
                        var selectField = ('section' + possitionX) + possitionY;
                        var unitId = redUnits[unit].id;
                        $('#' + selectField).addClass('redRanger');
                        $('#' + selectField).addClass('red');
                        if (redUnits[unit].mode == 'defend') {
                            $('#' + selectField).text('R-D');
                        }
                        else {
                            $('#' + selectField).text('R-A');
                        }
                        $('#' + selectField).attr('data-unit-id', unitId);
                    }
                }

                //console.log(data);
            })
        },
        loadOpenGameUI: function (selector) {
            this.persister.game.open()
                   .then(function (games) {
                       var openGames = UI.getOpenGames(games);
                       if (self.openGamesState != openGames) {
                           $('#openGames').html(openGames);
                           self.openGamesState = openGames;
                       }
                   });
        },
        loadMakeGameUI: function (selector) {
            var openGames = UI.getCreateGame();
            $(selector).append(openGames);
        },
        _getClickedPossition: function (data) {
            var coord = new Array();

            var x = data.attr('id')[7];
            var y = data.attr('id')[8];

            coord[0] = x;
            coord[1] = y;
            return coord;
        },
        _moveUnit: function () {
            var self = this;
            var element = $('.selected');
            var possition = this._nextPoss;
            console.log(possition);
            this.persister.battle.move(this._currGameData.gameId, element.attr('data-unit-id'), possition)
                  .then(function () {
                      self.loadFieldState(self._currGameData.gameId);
                  });
        },
        _attackUnit: function () {
            var self = this;
            var element = $('.selected');
            var possition = this._nextPoss;
            console.log(possition);
            this.persister.battle.attack(this._currGameData.gameId, element.attr('data-unit-id'), possition)
                  .then(function () {
                      self.loadFieldState(self._currGameData.gameId);
                  });
        },
        _defendUnit: function () {
            var self = this;
            var element = $('.selected');
            var unitId = element.attr('data-unit-id');
            this.persister.battle.defend(this._currGameData.gameId, element.attr('data-unit-id'), unitId)
                  .then(function () {
                      self.loadFieldState(self._currGameData.gameId);
                  });
        },
        loadBattleMenu: function () {
            var menu = UI.getBattleMenu();
            $('#battleMenu').html(menu);
        },
        addEventHendlersUI: function () {
            var wrapper = $(this.selector);
            var self = this;

            wrapper.on('click', '#login-btn', function (event) {
                event.preventDefault();
                event.stopPropagation();

                var username = $('#tb-username').val();
                var password = $('#tb-pass').val();
                self.persister.user.login(username, password)
                    .then(function () {
                        self.loadGameUI(selector);
                    }, function (message) {
                        $('#tb-username').val("");
                        $('#tb-pass').val("");
                        var texter = $('<h3 />');
                        texter.attr('id', 'fader');
                        texter.text('Incorect Data!');
                        $('#login-btn').after(texter);
                        $('#fader').fadeOut(5000);
                    }).done();

                return false;
            });
            wrapper.on('click', '#logout-btn', function (event) {
                event.preventDefault();
                event.stopPropagation();

                self.persister.user.logout().then(
                    function () {
                        self.loadUI(selector);
                        clearInterval(self.activeGameInterval);
                    }).done();
                return false;
            });
            wrapper.on('click', '#register-btn', function (event) {
                event.preventDefault();
                event.stopPropagation();

                var username = $('#tb-username').val();
                var nickname = $('#tb-nickname').val();
                var password = $('#tb-password').val();
                //console.log(username);
                //console.log(nickname);
                //console.log(password);
                self.persister.user.register(username, nickname, password).then(
                    function () {
                        self.loadGameUI(selector);
                    }, function (message) {
                        $('#tb-username').val("");
                        $('#tb-nickname').val("");
                        $('#tb-password').val("");
                        var texter = $('<h3 />');
                        texter.attr('id', 'fader');
                        texter.text('Incorect Data!');
                        $('#register-btn').after(texter);
                        $('#fader').fadeOut(5000);
                    }).done();

                return false;
            })
            wrapper.on('click', '#btn-show-register', function (event) {
                event.preventDefault();
                event.stopPropagation();

                var registerForm = UI.getRegisterForm();
                $('#inputConteiner').html(registerForm);
                return false;
            });
            wrapper.on('click', '#btn-show-login', function (event) {
                event.preventDefault();
                event.stopPropagation();

                var loginForm = UI.getLoginForm();

                $('#inputConteiner').html(loginForm);
                return false;
            });
            wrapper.on('click', '#make-btn', function (event) {
                event.preventDefault();
                event.stopPropagation();

                var title = $('#game-title').val();
                var password = $('#game-password').val();
                self.persister.game.create(title, password).then(
               function () {
                   $('#game-title').val("");
                   $('#game-password').val("");
                   var texter = $('<h3 />');
                   texter.attr('id', 'fader');
                   texter.text('You make game!');
                   $('#make-btn').after(texter);
                   $('#fader').fadeOut(2000);
               }, function (message) {
                   $('#game-title').val("");
                   $('#game-password').val("");
                   var texter = $('<h3 />');
                   texter.attr('id', 'fader');
                   texter.text('Incorect Data!');
                   $('#make-btn').after(texter);
                   $('#fader').fadeOut(5000);
               }).done();

                return false;
            });
            wrapper.on('click', '#openGames a', function (event) {
                event.preventDefault();
                event.stopPropagation();

                $("#joinGame").remove();
                $(this).after(UI.getJoinField());
                selectedGame = $(this);
                return false;
            });
            wrapper.on('click', '#join-btn', function (event) {
                var gameID = selectedGame.attr('data-game-id');
                var password = $('#game-password-join').val();
                self.persister.game.join(gameID, password).then(
               function () {
                   $('#game-password-join').val("");
                   var texter = $('<h3 />');
                   texter.attr('id', 'fader');
                   texter.text('You join to the game!');
                   $('#join-btn').after(texter);
                   $('#fader').fadeOut(2000);
                   selectedGame = "";
               }, function (message) {
                   alert('The numbers in number not be same!');
               }).done();

                return false;
            });
            wrapper.on('click', '#activeGames button', function (event) {
                event.preventDefault();
                event.stopPropagation();

                self.persister.game.start($(this).attr('id'));
            });
            wrapper.on('click', '#activeGames a', function (event) {
                event.preventDefault();
                event.stopPropagation();

                var selectedGame = $(this);
                if (selectedGame.next('div').hasClass('in-progress')) {
                    var gameId = selectedGame.attr('data-game-id');
                    self.loadFieldState(gameId);
                }
                else {
                    $('#battleField').html("");
                }
            });
            wrapper.on('click', '[data-unit-id]', function (event) {
                event.preventDefault();
                event.stopPropagation();
                var filedState = self.fieldState;
                var selectedUnit = $(this);

                var playerColor = '';
                if (filedState.red.nickname == localStorage.getItem('nickname')) {
                    playerColor = 'red';
                }
                else {
                    playerColor = 'blue';
                }

                if (filedState.inTurn == playerColor) {
                    if (selectedUnit.hasClass(playerColor)) {
                        $('.selected').removeClass('selected');
                        $('#' + selectedUnit.attr('id')).addClass('selected');
                        self.loadBattleMenu(selectedUnit);
                        self._isSelected = true;
                    }
                }
                else {
                        var texter = $('<h3 />');
                        texter.attr('id', 'fader');
                        texter.text('Not your turn!');
                        $('#battleField').before(texter);
                        $('#fader').fadeOut(5000);
                }

            });
            wrapper.on('click', '#battleField div', function (event) {
                event.preventDefault();
                event.stopPropagation();
                var filedState = self.fieldState;
                var selectedField = $(this);
                $('.secondSelected').removeClass('secondSelected');
                if (!selectedField.hasClass('selected')) {
                    selectedField.addClass('secondSelected');
                }

                var playerColor = '';
                if (filedState.red.nickname == localStorage.getItem('nickname')) {
                    playerColor = 'red';
                }
                else {
                    playerColor = 'blue';
                }

                if (filedState.inTurn == playerColor) {
                    if (self._isSelected) {
                        var coord = self._getClickedPossition(selectedField)
                        self._nextPoss = coord;
                    }
                }
                else {
                    console.log('Not yout turn');
                }

            });
            wrapper.on('click', '#move', function (event) {
                event.preventDefault();
                event.stopPropagation();

                self._moveUnit();
            });
            wrapper.on('click', '#attack', function (event) {
                event.preventDefault();
                event.stopPropagation();

                self._attackUnit();
            });
            wrapper.on('click', '#defend', function (event) {
                event.preventDefault();
                event.stopPropagation();

                self._defendUnit();
            });


        }
    });

    return {
        get: function (selector) {
            return new MainController(selector);
        }
    }
}());

$(function () {
    var constroller = Controller.get("#wrapper");
    constroller.loadUI();
});

