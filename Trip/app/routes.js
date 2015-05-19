(function() {
    'use strict';

    app.config(['$routeProvider', function($routeProvider) {
        $routeProvider
            .when('/home',
                {
                    templateUrl: 'partials/views/home.html',
                    controller: 'HomeController'
                })
            .when('/match-resultaten',
                {
                    templateUrl: 'partials/views/matchresults.html',
                    controller: 'MatchResultsController'
                })
        .when('/beheren-filters',
                {
                    templateUrl: 'partials/views/managefilters.html',
                    controller: 'ManageFiltersController'
                })
            .otherwise({ redirectTo: '/home' });
    }]);
}())