describe("Given the Taxi Fare app", function () {
    beforeEach(function () {
        angular.mock.module('app');
    });

    it("When init, it should set the title", inject(function ($rootScope) {
        expect($rootScope).toBeDefined();
        expect($rootScope.title).toBeDefined();
    }));
});