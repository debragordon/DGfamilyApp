app.controller("FamilyFormController", ["$scope", "$http", "$location", function ($scope, $http, $location) {
        console.log("FamilyForm controller connected");
        $scope.family = {};

        $scope.updateFamily = function () {
            $http.post('/api/family', $scope.family)
                .then(function(res) {
                    $location.url("/home");
                    $scope.family = {};
                });
        }
    }
]);