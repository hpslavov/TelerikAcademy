(function () {
    'use strict';

    function commits(data) {

        var currentUrl = 'api/commits';

        function getPublicCommits() {
            return data.get(currentUrl);
        }

        function createCommit(commit){
            return data.post(currentUrl,commit);
        }

        function getById(id){
            return data.get(currentUrl + '/' + id);
        }

        return {
            getPublicCommits: getPublicCommits,
            createCommit:createCommit,
            getById:getById
        }
    }

    angular.module('myApp.services')
        .factory('commits', ['data', commits])
}());