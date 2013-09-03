/// <reference path="jquery-2.0.2.js" />
/// <reference path="q.js" />

var Requester = function (url) {
    var rootUrl = url;

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

    var postRequest = function (url, data) {
        return makeRequest(url, 'POST', data);
    };

    var putRequest = function (url, data) {
        return makeRequest(url, 'PUT', data);
    };

    var getRequest = function (url) {
        return makeRequest(url, 'GET')
    };

    return {
        postRequest: postRequest,
        getRequest: getRequest,
        putRequest: putRequest
    }
}