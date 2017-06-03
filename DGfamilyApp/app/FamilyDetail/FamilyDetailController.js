app.controller("FamilyDetailController", ["$scope", "$http", "$location", "$routeParams" function ($scope, $http, $location, $routeParams) {
    console.log("FamilyDetail controller connected");
    $scope.selectedFamily = {};
    var familyId = $routeParams.id;
    $http.get(/api/family/${familyId})
        .then(function(oneFamily) {
    $scope.selectedFamily = oneFamily.data;
});

}
]);