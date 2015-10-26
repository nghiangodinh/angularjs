(function () {
	var app = angular.module('myApp', []);
	app.controller("ValidateController", ValidateController);

	// this = $scope
	function ValidateController() {
		var vm = this;

		vm.user = 'John Doe';
		vm.email = 'john.doe@gmail.com';
	}

})();



