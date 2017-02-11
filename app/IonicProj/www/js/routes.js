angular.module('app.routes', [])

.config(function($stateProvider, $urlRouterProvider) {

  // Ionic uses AngularUI Router which uses the concept of states
  // Learn more here: https://github.com/angular-ui/ui-router
  // Set up the various states which the app can be in.
  // Each state's controller can be found in controllers.js
  $stateProvider
    
  

      .state('tabsController.events', {
    url: '/events',
    views: {
      'tab4': {
        templateUrl: 'templates/events.html',
        controller: 'eventsCtrl'
      }
    }
  })

  .state('food', {
    url: '/food',
    templateUrl: 'templates/food.html',
    controller: 'foodCtrl'
  })

  .state('drinks', {
    url: '/drinks',
    templateUrl: 'templates/drinks.html',
    controller: 'drinksCtrl'
  })

  .state('tabsController', {
    url: '/page1',
    templateUrl: 'templates/tabsController.html',
    abstract:true
  })

  .state('tabsController.bookingVerifica', {
    url: '/booking2',
    views: {
      'tab4': {
        templateUrl: 'templates/bookingVerifica.html',
        controller: 'bookingVerificaCtrl'
      }
    }
  })

  .state('tabsController.bookingConferma', {
    url: '/booking3',
    views: {
      'tab4': {
        templateUrl: 'templates/bookingConferma.html',
        controller: 'bookingConfermaCtrl'
      }
    }
  })

  .state('tabsController.bookingRichiesta', {
    url: '/booking1',
    views: {
      'tab4': {
        templateUrl: 'templates/bookingRichiesta.html',
        controller: 'bookingRichiestaCtrl'
      }
    }
  })

  .state('tabsController.logIn', {
    url: '/login',
    views: {
      'tab3': {
        templateUrl: 'templates/logIn.html',
        controller: 'logInCtrl'
      }
    }
  })

  .state('tabsController.dashboard', {
    url: '/dashboard',
    views: {
      'tab3': {
        templateUrl: 'templates/dashboard.html',
        controller: 'dashboardCtrl'
      }
    }
  })

  .state('settings', {
    url: '/settings',
    templateUrl: 'templates/settings.html',
    controller: 'settingsCtrl'
  })

  .state('feedback', {
    url: '/feedback',
    templateUrl: 'templates/feedback.html',
    controller: 'feedbackCtrl'
  })

  .state('location', {
    url: '/location',
    templateUrl: 'templates/location.html',
    controller: 'locationCtrl'
  })

  .state('share', {
    url: '/share',
    templateUrl: 'templates/share.html',
    controller: 'shareCtrl'
  })

$urlRouterProvider.otherwise('/page1/dashboard')

  

});