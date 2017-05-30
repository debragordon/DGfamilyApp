var app = angular.module("FamilyApp", ["ngRoute"]);

app.config([
    "$routeProvider", function ($routeProvider) {
        $routeProvider
            .when("/login",
                {
                    templateUrl: "app/Login/Login.html",
                    controller: "LoginController"
                })
            .when("/home",
                {
                    templateUrl: "app/Home/Home.html",
                    controller: "HomeController"
                })
            .when("/family/{id}",
                {
                    templateUrl: "app/FamilyDetail/FamilyDetail.html",
                    controller: "FamilyDetailController"
                })
            .when("/family/update",
                {
                    templateUrl: "app/FamilyForm/FamilyForm.html",
                    controller: "FamilyFormController"
                })
            .when("/member/{id}",
                {
                    templateUrl: "app/MemberDetail/MemberDetail.html",
                    controller: "MemberDetailController"
                })
            .when("/member/update",
                {
                    templateUrl: "app/MemberForm/MemberForm.html",
                    controller: "MemberFormController"
                })
            .when("/register",
                {
                    templateUrl: "app/Register/Register.html",
                    controller: "RegisterController"
                });
    }
]);