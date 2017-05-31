var app = angular.module("FamilyApp", ["ngRoute"]);

var isAuth = function () {
    return sessionStorage.getItem("token") ? true : false;
};

app.run(($rootScope, $location) => {

    $rootScope.$on('$routeChangeStart', function (event, currRoute, prevRoute) {
        var logged = isAuth();
        var appTo;
        if (currRoute.originalPath) {
            appTo = currRoute.originalPath.indexOf('/login') !== -1;
        }
        if (!appTo && !logged) {
            event.preventDefault();
            $location.path('/login');
        }
    });
});


app.config(["$routeProvider", "$locationProvider", function ($routeProvider, $locationProvider) {
        $routeProvider
            .when("/login",
                {
                    templateUrl: "app/Login/Login.html",
                    controller: "LoginController"
                })
            .when("/home",
                {
                    templateUrl: "app/Home/Home.html",
                    controller: "HomeController",
                    resolve: { isAuth }
                })
            .when("/family/{id}",
                {
                    templateUrl: "app/FamilyDetail/FamilyDetail.html",
                    controller: "FamilyDetailController",
                    resolve: { isAuth }
                })
            .when("/family/update",
                {
                    templateUrl: "app/FamilyForm/FamilyForm.html",
                    controller: "FamilyFormController",
                    resolve: { isAuth }
                })
            .when("/member/{id}",
                {
                    templateUrl: "app/MemberDetail/MemberDetail.html",
                    controller: "MemberDetailController",
                    resolve: { isAuth }
                })
            .when("/member/update",
                {
                    templateUrl: "app/MemberForm/MemberForm.html",
                    controller: "MemberFormController",
                    resolve: { isAuth }
                })
            .when("/register",
                {
                    templateUrl: "app/Register/Register.html",
                    controller: "RegisterController"
                })
            .otherwise({
                redirectTo:'/login'
            });
        $locationProvider.html5Mode(true);
    }
]);