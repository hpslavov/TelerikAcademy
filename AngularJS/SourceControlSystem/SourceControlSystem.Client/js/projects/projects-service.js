(function () {
    'use strict';

    function projects(data) {

        var CURRENT_URL = 'api/projects'

        function getPublicProjects() {
            return data.get(CURRENT_URL);
        }

        function createProject(project) {
            return data.post(CURRENT_URL, project);
        }

        function filterProjects(filters) {
            return data.get(CURRENT_URL + '/all', filters);
        }
        
        function getById(id){
            return data.get(CURRENT_URL + '/' + id);
        }

        return {
            getPublicProjects: getPublicProjects,
            createProject: createProject,
            filterProjects: filterProjects,
            getById: getById
        }
    }

    angular.module('myApp.services')
        .factory('projects', ['data', projects]);
}());