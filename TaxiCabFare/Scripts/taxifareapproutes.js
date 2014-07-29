var app = angular.module("taxifarecalc", ['ngRoute'])
.config(function ($routeProvider, $locationProvider) {
    $routeProvider.when('/Home/Index', { templateUrl: '/ngViews/mainpage.html', controller: 'MainController' });
    $locationProvider.html5Mode(true);
});
