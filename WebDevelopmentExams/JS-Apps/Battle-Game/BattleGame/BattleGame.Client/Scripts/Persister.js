/// <reference path="q.js" />
/// <reference path="class-create-inherit.js" />
/// <reference path="Requester.js" />

var Persister = function () {
    var requester = Requester('http://localhost:22954/api/');

    var MainPersister = Class.create({
        init: function (rootUrl) {
            this.rootUrl = rootUrl;
            this.user = new UserController();
            this.game = new GameController();
            this.battle = new BattleController();
            this.message = new MessagePersister();
        },
        isLoggedin: function () {
            if (localStorage.getItem("sessionKey")) {
                return true;
            }
            else {
                return false;
            }
        }
    });
    var UserController = Class.create({
        init: function () {
            this.rootURL = 'user/';
        },
        login: function (username, password) {
            var authCode = CryptoJS.SHA1(username + password).toString();
            var data = {
                username: username,
                authCode: authCode
            };
            return requester.postRequest(this.rootURL + 'login/', data)
                .then(function (data) {
                    localStorage.setItem("sessionKey", data.sessionKey);
                    localStorage.setItem("nickname", data.nickname);
                });
        },
        logout: function () {
            return requester.getRequest(this.rootURL + 'logout/' + localStorage.getItem("sessionKey")).then
                 (function (respMess) {
                     localStorage.clear("sessionKey");
                     localStorage.clear("nickname");
                 });
        },
        register: function (username, nickname, password) {
            var authCode = CryptoJS.SHA1(username + password).toString();
            //console.log(authCode);
            var data = {
                username: username,
                nickname: nickname,
                authCode: authCode
            };

            return requester.postRequest(this.rootURL + 'register/', data).then
                  (function (data) {
                      var sessionKey = data.sessionKey;
                      var nickname = data.nickname;

                      localStorage.setItem("sessionKey", sessionKey);
                      localStorage.setItem("nickname", nickname);
                  });
        },
        score: function () {
            return requester.getRequest(this.rootURL + 'scores/' + localStorage.getItem('sessionKey'));
        }
    });
    var GameController = Class.create({
        init: function () {
            this.rootURL = 'game/';
        },
        create: function (title, password) {
            var criptPassword = CryptoJS.SHA1(password).toString();

            var data = {
                title: title,
                password: criptPassword
            }

            return requester.postRequest(this.rootURL + 'create/' + localStorage.getItem('sessionKey'), data);
        },
        active: function () {
            return requester.getRequest(this.rootURL + 'my-active/' + localStorage.getItem('sessionKey'));
        },
        open: function () {
            return requester.getRequest(this.rootURL + 'open/' + localStorage.getItem('sessionKey'));
        },
        join: function (gameId, password) {
            var criptPassword = CryptoJS.SHA1(password).toString();
            var data = {
                id: gameId,
                password: criptPassword
            }
            return requester.postRequest(this.rootURL + 'join/' + localStorage.getItem('sessionKey'), data);
        },
        start: function (gameId) {
            return requester.getRequest(this.rootURL + gameId + '/start/' + localStorage.getItem('sessionKey'));
        },
        field: function (gameId) {
            return requester.getRequest(this.rootURL + gameId + '/field/' + localStorage.getItem('sessionKey'));
        }
    });
    var BattleController = Class.create({
        init: function () {
            this.rootURL = 'battle/';
        },
        move: function (gameId, unitId, position) {
            var makePossition = {
                x: position[0],
                y: position[1]
            }
            var data = {
                unitId: unitId,
                position: makePossition
            }

            return requester.postRequest(this.rootURL + gameId + '/move/' + localStorage.getItem('sessionKey'), data);
        },
        attack: function (gameId, unitId, position) {
            var makePossition = {
                x: position[0],
                y: position[1]
            }
            var data = {
                unitId: unitId,
                position: makePossition
            }

            return requester.postRequest(this.rootURL + gameId + '/attack/' + localStorage.getItem('sessionKey'), data);
        },
        defend: function (gameId, unitId) {
            return requester.postRequest(this.rootURL + gameId + '/defend/' + localStorage.getItem('sessionKey'), unitId);
        }
    });
    var MessagePersister = Class.create({
        init: function (serviceRootUrl, userPersister) {
            this.rootURL = 'messages/';
        },
        unread: function () {
            return requester.getRequest(this.rootURL + "unread/" + localStorage.getItem('sessionKey'));
        },
        all: function () {
            return requester.getRequest(this.rootURL + "all/" + localStorage.getItem('sessionKey'));
        }
    });

    return {
        mainPersister: function () {
            return new MainPersister();
        }
    }
}