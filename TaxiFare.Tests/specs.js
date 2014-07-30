'use strict';

/// <reference path="Scripts/jasmine.js"/>
/// <reference path="Scripts/angular.js"/>
/// <reference path="Scripts/angular-resource.js"/>
/// <reference path="Scripts/angular-mocks.js"/>
/// <reference path="../TaxiFare/Scripts/taxifarectrl.js"/>
/// <reference path="../TaxiFare/Scripts/taxifareapproutes.js"/>


(function () {

    describe("Given the Taxi Fare app", function () {
        
//        var $controllerConstructor;
//        var scope;

//        beforeEach(module('app'));

//        beforeEach(inject(function($controller, $rootScope){
//            $controllerConstructor = $controller;
//            scope = $rootScope.$new();
//        }));

//        it('should have 3 text boxes', function(){
//            var ctrl = $controllerConstructor('MainController',{$scope.scope});
//            expect(ctrl.textboxes.length).toBe(3);
//        }));

//        beforeEach(function () {
//            angular.mock.module('taxifarecalc');
//        });

//        describe("Use MainController", function(){
//            it("uses the MainController", function(){
//                var ctrler = new app.collections.

//        it("When init, it should set the title", inject(function ($rootScope) {
//            expect($rootScope).toBeDefined();
//            expect($rootScope.title).toBeDefined();
//        }));

        beforeEach(function(){
            module('taxifarecalc');
        });

        it("When init, it should set the title", inject(function ($rootScope) {
            expect($rootScope).toBeDefined();
        }));

        beforeEach(inject(function($controller,$rootScope){
            scope = $rootScope.$new();
            controller = $controller("MainController", {
                $scope: scope
            });
        }));

        it('should expect test', function ($rootScope) {
            //var scope = $rootScope;
            expect(scope.test).toBe("hi");
        });


//        beforeEach(inject(function(_$rootScope_, _$controller_){
//            $rootScope = _$rootScope_;
//            $scope = $rootScope.$new();
//            $controller = _$controller_;

//            $controller('MainController',{'$rootScope':$rootScope, '$scope':$scope});
//        
//        }));

//        it('should set the title.', function(){
//            expect($rootScope.activeMenu.about == 'active');
//        });


    });

} ());
