﻿
var app = angular.module("app", []);

app.controller("IndexController", ["$scope", function ($scope) {

    $scope.name = "Ashish verma";
    $scope.names = ['Amit', 'Ashish', 'Rohit', 'Aslam', 'Saurabh'];
}]);