(function () { 
    'use strict';

    function ProjectsController(projects,identity){
        var vm = this;
        vm.identity = identity;

        vm.request = {
            Page: 1,
            PageSize:10
        }

        vm.prevPage = function () {
            if (vm.request.Page === 1) {
                return;
            }
            vm.request.Page--;
            vm.filterProjects();
        }

        vm.nextPage = function () {

            vm.request.Page++;
            vm.filterProjects();
        }

        projects.getPublicProjects()
            .then(function (publicProjects) {
                vm.projects = publicProjects;
            });


        vm.filterProjects = function(){
            projects.filterProjects(vm.request)
                .then(function (filteredProjects) {
                    console.log(filteredProjects);
                    console.log(vm.request);
                    vm.projects = filteredProjects;
                });
        }

    }

    angular.module('myApp.controllers')
        .controller('ProjectsController',['projects','identity',ProjectsController]);
}());