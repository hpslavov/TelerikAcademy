(function () { 
    'use strict';

    function CommitsController(commits,notifier,identity){

        var vm = this;
        vm.identity = identity;
        commits.getPublicCommits()
            .then(function (responseCommits) {
                vm.commits = responseCommits;
            });

    }

    angular.module('myApp.controllers')
        .controller('CommitsController',['commits','notifier','identity',CommitsController]);
}());