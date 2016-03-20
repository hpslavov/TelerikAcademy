(function () {
    'use strict';

    function CreateCommitController(commits, notifier, identity,$location) {

        var vm = this;
        vm.identity = identity;

        vm.commit = {};
        
        vm.createCommit = function(){
            commits.createCommit(vm.commit)
                .then(function (response) {
                    notifier.success('Successfully Commited to Project ' + vm.commit.projectId);
                    $location.path('/commits/' + vm.commit.projectId);
                });
        }

    }

    angular.module('myApp.controllers')
        .controller('CreateCommitController', ['commits', 'notifier', 'identity','$location', CreateCommitController]);
}());