walmartApp.service('productService', function() {
    
    this.product = "";
    
});


walmartApp.service('searchService', function($resource) {
    
  this.search = $resource("https://api.walmartlabs.com/v1/search?apiKey=d9bgdny53rhfkkw6sg9xpjgu", {callback: "JSON_CALLBACK"}, {get:{method: "JSONP"}}); 
    
});

walmartApp.service('lookupService', function($resource) {
    
 this.lookup = $resource("https://api.walmartlabs.com/v1/items?apiKey=d9bgdny53rhfkkw6sg9xpjgu", {callback: "JSON_CALLBACK"}, {get:{method: "JSONP"}}); 
    
});

walmartApp.service('recommendService', function($resource) {
    
  this.recommend = $resource("http://api.walmartlabs.com/v1/nbp?apiKey=d9bgdny53rhfkkw6sg9xpjgu", {},  {query: {method: "JSONP", isArray: true
                                                                                                                                         
    }}); 
    
});
