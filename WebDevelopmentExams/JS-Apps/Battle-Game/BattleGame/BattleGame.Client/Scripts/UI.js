var UI = (function () {

    var loadLoginForm = function () {

        var html =
        '<form id="form-login">' +
            '<fieldset>' +
                '<legend>Login form</legend>' +

                '<label for="tb-username">Username: </label>' +
                    '<input type="text" id="tb-username" placeholder="Enter username" /><br />' +

                '<label for="tb-pass">Password: </label>' +
                    '<input type="password" id="tb-pass" placeholder="Enter password" /><br />' +
                '<button id="login-btn">Login</button>'
        '</fieldset>' +
    '</form> ';

        return html;
    }

    var loadRegisterForm = function () {
        var html =
            '<form id="form-register">' +
                '<fieldset>' +
                    '<legend>Registration form</legend>' +

                    '<label for="tb-username">Username: </label>' +
                        '<input type="text" id="tb-username" placeholder="Enter username" /><br />' +
                         '<label for="tb-nickname">Nickname: </label>' +
                        '<input type="text" id="tb-nickname" placeholder="Enter nickname" /><br />' +
                    '<label for="tb-password">Password: </label>' +
                        '<input type="password" id="tb-password" placeholder="Enter password" /><br />' +


                    '<button id="register-btn">Register</button>' +
                '</fieldset>' +
            '</form>';

        return html;
    }

    var loadInputForms = function () {
        var html =
        '<div id="loginAndRegForms">' +
            '<a href="#" id="btn-show-register" class="btn-login-form">Register</a> / ' +
            '<a href="#" id="btn-show-login" class="btn-login-form">Login</a>' +
        '</div>' +
        '<div id="inputConteiner">' +

        '</div>';

        return html;
    }

    var loadGameUI = function () {
        var html =
        '<div id="userWrapper">' +
            'Wellcome,<span id="wellcome"></span>!' +
            '<p id="score">Your score: <span></span> pt.</p>' +
            '<div id="messages">' +
                '<h2>Messages:</h2>' +
                '<div id="messagesConteiner">' +
                    '<ul id="messagesList">' +
                    '</ul>' +
                '</div>' +
            '</div>' +
            '<a href="#" class="button" id="logout-btn">Logout</a>' +
        '</div>' +
        '<div id="createGame"></div>' +
        '<div id="gameField">' +
            '<div id="openGames">' +
                '<ul>' +
                '</ul>' +
            '</div>' +
            '<div id="playGame">' +
                '<h2>Play Games</h2>' +
                '<div id="battleMenu">   </div>'+
                '<div id="battleField">' +
                '</div>' +
            '</div>' +
            '<div id="activeGames">' +

            '</div>' +
        '</div>';

        return html;
    }

    var loadActiveGames = function (games) {
        var html =
         ' <h2>Active games</h2>' +
         '  <ul>';
        for (var game in games) {
            var currGame = games[game];
            var li = '<li><a href="#" data-game-id=' + currGame.id + '>' + currGame.title + '</a>';

            html += li;
        }

        return html;
    }

    var loadOpenGames = function (games) {

        var html =
         ' <h2>Open games</h2>' +
         '  <ul>';
        for (var game in games) {
            var currGame = games[game];
            var li = '<li><a href="#" data-game-id=' + currGame.id + '>' + currGame.title + '</a>';

            html += li;
        }

        return html;
    }

    var loadCreateGame = function () {

        var html =
            ' <h1>Make Game</h1>' +
              '  <form>' +
              '  <label for="game-title">Title: </label>' +
              '  <input type="text" id="game-title" /><br>' +
              '  <label for="game-password">Password: </label>' +
              '  <input type="password" id="game-password" /><br>' +
              '  <button id="make-btn">Make</button>' +
              '</form>';

        return html;
    }

    var loadJoinGameFields = function () {

        var html =
              '  <form id="joinGame">' +
              '  <label for="game-password-join">Password: </label><br>' +
              '  <input type="password" id="game-password-join" /><br>' +
              '  <button id="join-btn">Join</button>' +
              '</form>';

        return html;
    }

    var loadBattleField = function (blueName, redName) {

        var html =
            '<h3>' + blueName + ' VS ' + redName + '</h3>' +
        '    <div id="section00" class="sectionField"></div>' +
        '    <div id="section01" class="sectionField"></div>' +
        '    <div id="section02" class="sectionField"></div>' +
        '    <div id="section03" class="sectionField"></div>' +
        '    <div id="section04" class="sectionField"></div>' +
        '    <div id="section05" class="sectionField"></div>' +
        '    <div id="section06" class="sectionField"></div>' +
        '    <div id="section07" class="sectionField"></div>' +
        '    <div id="section08" class="sectionField"></div>' +

        '    <div id="section10" class="sectionField"></div>' +
        '    <div id="section11" class="sectionField"></div>' +
        '    <div id="section12" class="sectionField"></div>' +
        '    <div id="section13" class="sectionField"></div>' +
        '    <div id="section14" class="sectionField"></div>' +
        '    <div id="section15" class="sectionField"></div>' +
        '    <div id="section16" class="sectionField"></div>' +
        '    <div id="section17" class="sectionField"></div>' +
        '    <div id="section18" class="sectionField"></div>' +

        '    <div id="section20" class="sectionField"></div>' +
        '    <div id="section21" class="sectionField"></div>' +
        '    <div id="section22" class="sectionField"></div>' +
        '    <div id="section23" class="sectionField"></div>' +
        '    <div id="section24" class="sectionField"></div>' +
        '    <div id="section25" class="sectionField"></div>' +
        '    <div id="section26" class="sectionField"></div>' +
        '    <div id="section27" class="sectionField"></div>' +
        '    <div id="section28" class="sectionField"></div>' +

        '    <div id="section30" class="sectionField"></div>' +
        '    <div id="section31" class="sectionField"></div>' +
        '    <div id="section32" class="sectionField"></div>' +
        '    <div id="section33" class="sectionField"></div>' +
        '    <div id="section34" class="sectionField"></div>' +
        '    <div id="section35" class="sectionField"></div>' +
        '    <div id="section36" class="sectionField"></div>' +
        '    <div id="section37" class="sectionField"></div>' +
        '    <div id="section38" class="sectionField"></div>' +

        '    <div id="section40" class="sectionField"></div>' +
        '    <div id="section41" class="sectionField"></div>' +
        '    <div id="section42" class="sectionField"></div>' +
        '    <div id="section43" class="sectionField"></div>' +
        '    <div id="section44" class="sectionField"></div>' +
        '    <div id="section45" class="sectionField"></div>' +
        '    <div id="section46" class="sectionField"></div>' +
        '    <div id="section47" class="sectionField"></div>' +
        '    <div id="section48" class="sectionField"></div>' +

        '    <div id="section50" class="sectionField"></div>' +
        '    <div id="section51" class="sectionField"></div>' +
        '    <div id="section52" class="sectionField"></div>' +
        '    <div id="section53" class="sectionField"></div>' +
        '    <div id="section54" class="sectionField"></div>' +
        '    <div id="section55" class="sectionField"></div>' +
        '    <div id="section56" class="sectionField"></div>' +
        '    <div id="section57" class="sectionField"></div>' +
        '    <div id="section58" class="sectionField"></div>' +

        '    <div id="section60" class="sectionField"></div>' +
        '    <div id="section61" class="sectionField"></div>' +
        '    <div id="section62" class="sectionField"></div>' +
        '    <div id="section63" class="sectionField"></div>' +
        '    <div id="section64" class="sectionField"></div>' +
        '    <div id="section65" class="sectionField"></div>' +
        '    <div id="section66" class="sectionField"></div>' +
        '    <div id="section67" class="sectionField"></div>' +
        '    <div id="section68" class="sectionField"></div>' +

        '    <div id="section70" class="sectionField"></div>' +
        '    <div id="section71" class="sectionField"></div>' +
        '    <div id="section72" class="sectionField"></div>' +
        '    <div id="section73" class="sectionField"></div>' +
        '    <div id="section74" class="sectionField"></div>' +
        '    <div id="section75" class="sectionField"></div>' +
        '    <div id="section76" class="sectionField"></div>' +
        '    <div id="section77" class="sectionField"></div>' +
        '    <div id="section78" class="sectionField"></div>' +

        '    <div id="section80" class="sectionField"></div>' +
        '    <div id="section81" class="sectionField"></div>' +
        '    <div id="section82" class="sectionField"></div>' +
        '    <div id="section83" class="sectionField"></div>' +
        '    <div id="section84" class="sectionField"></div>' +
        '    <div id="section85" class="sectionField"></div>' +
        '    <div id="section86" class="sectionField"></div>' +
        '    <div id="section87" class="sectionField"></div>' +
        '    <div id="section88" class="sectionField"></div>';

        return html;
    }

    var loadBattleMenu = function () {
        var html =
            '            ' +
            '    <ul>                            ' +
            '        <li id="move">Move</li>     ' +
            '        <li id="attack">Attack</li> ' +
            '        <li id="defend">Deffend</li>' +
        '    </ul>                           ' +
        '                              ';

        return html;
    }

    return {
        getLoginForm: loadLoginForm,
        getRegisterForm: loadRegisterForm,
        getInputForms: loadInputForms,
        getGameUI: loadGameUI,
        getActiveGames: loadActiveGames,
        getOpenGames: loadOpenGames,
        getCreateGame: loadCreateGame,
        getJoinField: loadJoinGameFields,
        getGameField: loadBattleField,
        getBattleMenu: loadBattleMenu
    }
}());