(function () {
    'use strict';

    app.service('matchDataService', ['$http', function ($http) {
        var result = {
            getMatches: function () {
                var data = {
                    name: 'hello',
                    beginDate: '2015-05-15',
                    endDate: '2015-06-15',
                    status: 1
                };
                return $http.get('/api/match/getmatches', { params: data });
            }
        };

        return result;
    }]);
}())