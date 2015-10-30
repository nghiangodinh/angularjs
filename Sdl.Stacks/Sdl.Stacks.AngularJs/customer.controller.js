(function () {
  'use strict';

  angular
			.module('app')
			.controller('CustomerController', CustomerController);

  CustomerController.$inject = ['$location'];

  function CustomerController($location) {
    /* jshint validthis:true */
    var vm = this;
    vm.title = 'customer';

    activate();

    function activate() { }
  }
})();
