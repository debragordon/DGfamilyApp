﻿app.controller("LoginController", ["$scope", "$http", "$location", function ($scope, $http, $location) {
        console.log("Login controller connected");
        $scope.username = "";
        $scope.password = "";
        $scope.login = function () {
            $http({
                    method: 'POST',
                    url: "/Token",
                    headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
                    transformRequest: function (obj) {
                        var str = [];
                        for (var p in obj)
                            str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                        return str.join("&");
                    },
                    data: { grant_type: "password", username: $scope.username, password: $scope.password }
                })
                .then(function () {
                    console.log("result", result);

                    sessiontStorage.setItem('token', result.data.access_token);

                    $http.defaults.headers.common['Authorization'] = `bearer ${result.data.access_token}`;

                    $location.path("/home");
                });
        }
    }
]);