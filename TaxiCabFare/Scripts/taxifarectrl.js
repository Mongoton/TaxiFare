//app.controller("MainController", function ($scope, $location, processcalc) {
//    $scope.calculate = function (ride) {
//        $scope.error = false;
//        processcalc.execute(ride).then(
//            function() {$location.url('Home/Index');},
//            function() {$scope.error = true;});

//            result.success(function (data) {
//            //alert("heretest2");
//            $scope.totalfare = data.result;
//            //alert("heretest3");
//        });
    
//    };
    
//});

//app.factory('processcalc', function($http, $q){
//    return {
//        execute: function (rideinfo){
//            var deferred = $q.defer();
//            $http.post('Home/Index', rideinfo)
//                .success(function(){deferred.resolve();})
//                .error(function(){deferred.reject();});
//            return deferred.promise;
//        }
//    }
//}


app.controller("MainController", function ($scope, $http) {
    $scope.calculate = function (ride) {
        var result = $http.post("/Home/Index/", ride);
        result.success(function (data) {
            $scope.totalfare = data.result;
        });
    };
});

//app.directive("submitbutan", function ($http, $routeParams) {
//    return {

//    };
//});