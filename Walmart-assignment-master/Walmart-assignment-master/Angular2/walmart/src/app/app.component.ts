import { Component, SecurityContext } from '@angular/core';

import{NgForm} from '@angular/forms';
import {ActivatedRoute} from '@angular/router';
import {Product} from '../../product';
import {StoreService} from './store.service';
//import {Currentsearch} from './currentsearch';
import {Location} from '@angular/common';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

@Component({
  selector: 'wa-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [StoreService]

  //directives:[SearchResultsComponent]
})

// sticky fixed navigation

export class AppComponent  {
  constructor(private ss:StoreService, private location: Location, private route: ActivatedRoute) { }
statusMessage: string = 'loading data';
//  Product: Currentsearch[] =[];
searchRes: Product[];
  searchStr:string;

  title = 'wa works';

  clear(form: NgForm){
    form.resetForm(this.searchStr);
  }

  onSubmit(productForm:NgForm){
var array = [];
//  productForm.resetForm;
    //this.Product.splice(0, this.Product.length);

    if(!this.searchStr)
    window.open("error.html", "");
    else
        this.ss.Search(this.searchStr).subscribe(


          (data)=>{

if(data.totalResults ==0)
location.assign('/error');
          //  alert("Could not find product. Please search again.");

      var ids = data.itemId;

      for(var i = 0; i < 10; i++)
      {
      var id = data.items[i].itemId;
      array.push(id);

      }
      var things = array.join();

      this.ss.Lookup(things).subscribe(
      (response)=>

    this.searchRes = response.items

)});

}
}
