(function () {
    'use strict';

    app.controller('MatchResultsController', ['$scope', 'matchDataService', function ($scope, matchDataService) {
        $scope.title = 'Match resultaten';
        $scope.alerts = [
            { type: 'danger', msg: 'Oh snap! Change a few things up and try submitting again.' },
            { type: 'success', msg: 'Well done! You successfully read this important alert message.' }
        ];
        $scope.matches = [];

        $scope.closeAlert = function (index) {
            $scope.alerts.splice(index, 1);
        };

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