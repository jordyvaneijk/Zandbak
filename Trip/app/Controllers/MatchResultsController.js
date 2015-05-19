(function () {
    'use strict';

    app.controller('MatchResultsController', ['$scope', 'matchDataService', function ($scope, matchDataService) {
        $scope.title = 'Match resultaten';

        $scope.matches = [];

        function getMatches() {
            matchDataService.getMatches()
                .success(function (data) {
                    for (var i = 0; i < data.length; i++) {
                        $scope.matches.push({ collapsed: true, container: data[i] });
                    }

                   // $scope.matches = data;
                })
                .error(function (data) {
                    alert(data);
                });
        }

        getMatches();
    }]);
}())