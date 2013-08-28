/// <reference path="jquery-2.0.2.js" />
/// <reference path="q.js" />

var Requester = function (url) {
    var rootUrl = url;

    var postRequest = function (url, data) {
        return makeRequest(url, 'POST', data);
    };

    var getRequest = function (url) {
        return makeRequest(url, 'GET')
    };

    var makeRequest = function (url, type, data) {
        var deferred = Q.defer();

        var urlReq = rootUrl + url;
        var typeReq = type;
        var dataReq = JSON.stringify(data);

        $.ajax({
            url: urlReq,
            type: typeReq,
            contentType: "application/json",
            data: dataReq || "",
            success: function (data) {
                deferred.resolve(data);
            },
            error: function (errorM) {
                deferred.reject(errorM);
            }
        });

        return deferred.promise;
    }

    return {
        postRequest: postRequest,
        getRequest: getRequest
    }
}