
app.controller("MainController", function ($scope, $http) {
    $scope.test = "hi";
    $scope.calculate = function (ride) {
        var result = $http.post("/Home/GetRideInfo/", ride);
        result.success(function (data) {
            $scope.totalfare = data.result;
        });
    };
});


//A custom directive
app.directive('appTitle', function () {
    return {
        restrict: 'E',
        compile: function (elem) {
            elem.replaceWith("<h1>Taxi Cab Fare Calculation</h1>");
        }
    }
});
