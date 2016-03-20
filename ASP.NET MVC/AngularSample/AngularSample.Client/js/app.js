(function () {
    'use strict';

    function config($routeProvider) {

        var PARTIALS_PREFIX = 'views/partials';
        var CONTROLLER_NAME = 'vm';

        $routeProvider
            .when('/', {
                templateUrl: PARTIALS_PREFIX + '/home/home.html',
                controller: 'HomeController',
                controllerAs: CONTROLLER_NAME
            })
            .when('/unauthorized', {
                template: '<h1 class="text-center">YOU NOT AUTHORIZED!</h1>'
            })
            .when('/register', {
                templateUrl: PARTIALS_PREFIX + '/identity/register.html',
                controller: 'SignUpCtrl'
            })
            .when('/projects',{
                templateUrl: PARTIALS_PREFIX + '/projects/all-projects.html',
                controller: 'ProjectsController',
                controllerAs: CONTROLLER_NAME
            })
             .when('/projects/add', {
                templateUrl: PARTIALS_PREFIX + '/projects/create-project.html',
                controller: 'CreateProjectController',
                controllerAs: CONTROLLER_NAME
            })
             .when('/projects/:id', {
                 templateUrl: PARTIALS_PREFIX + '/projects/project-details.html',
                 controller: 'ProjectDetailsController',
                 controllerAs: CONTROLLER_NAME
             })
            .when('/commits',{
                templateUrl: PARTIALS_PREFIX + '/commits/all-commits.html',
                controller: 'CommitsController',
                controllerAs: CONTROLLER_NAME
            })
             .when('/commits/create', {
                 templateUrl: PARTIALS_PREFIX + '/commits/create-commit.html',
                 controller: 'CreateCommitController',
                 controllerAs: CONTROLLER_NAME
             })
            .when('/commits/:id',{
                templateUrl: PARTIALS_PREFIX + '/commits/commits-details.html',
                controller: 'CommitsDetailsController',
                controllerAs: CONTROLLER_NAME
            })
            .otherwise({ redirectTo: '/' });
    }

    angular.module('myApp.services', []);
    angular.module('myApp.directives', []);
    angular.module('myApp.filters',[]);
    angular.module('myApp.controllers', ['myApp.services']);
    angular.module('myApp', ['ngRoute', 'kendo.directives','ngCookies', 'myApp.controllers', 'myApp.directives','myApp.filters']).
        config(['$routeProvider', config])
        .value('toastr', toastr)
        .constant('baseServiceUrl', 'http://spa.bgcoder.com');
}());