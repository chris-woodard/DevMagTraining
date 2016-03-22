var designerModule = angular.module('designer');
angular.module('designer').requires.push('sfSelectors');

angular.module('designer').controller('Authors', ['$scope', 'propertyService', 'serverData', function ($scope, propertyService, serverData) {
    $scope.itemType = "Telerik.Sitefinity.DynamicTypes.Model.Authors.Author";
}]);