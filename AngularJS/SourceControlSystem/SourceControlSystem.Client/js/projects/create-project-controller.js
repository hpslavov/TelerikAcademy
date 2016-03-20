(function(){
    'use strict';

    function CreateProjectController($location,projects,notifier,licenses){

         var vm = this;
         licenses.getLicenses()
            .then(function (responseLicenses) {
                vm.licenses = responseLicenses;
            });

         vm.createProject = function (project) {
             console.log(project);
             projects.createProject(project)
                .then(function (response) {
                    notifier.success('Project Created!');
                    $location.path('/projects');
                }, function (err) {
                    notifier.error(err.message);
                });
         }

        }

    angular.module('myApp.controllers')
        .controller('CreateProjectController',['$location','projects','notifier','licenses',CreateProjectController]);
}());