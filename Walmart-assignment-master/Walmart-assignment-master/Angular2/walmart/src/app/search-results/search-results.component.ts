import { Component, OnInit, OnDestroy } from '@angular/core';
import { NgForm } from '@angular/forms';
import {ActivatedRoute} from '@angular/router';
import 'rxjs/Rx';
import {Product} from '../../../product';
import { Location } from "@angular/common";

import {StoreService} from '../store.service';
//import {Currentsearch} from '../currentsearch';

@Component({
  moduleId:module.id,
  selector: 'wa-search-results',
  templateUrl: './search-results.component.html',
  styleUrls: ['./search-results.component.css']
})
export class SearchResultsComponent implements OnInit {
//  mySearch:Currentsearch;
  itemId:string;

  //Product: Currentsearch[] =[];
  searchRes: Product[];
  searchRec: Product[];
  constructor(private ss:StoreService, private location: Location, private route:ActivatedRoute) { }

  ngOnInit() {
//this.searchRes.splice(0, this.searchRes.length);
this.route.params.map(params => params['itemId']).subscribe((itemId) =>
{

  this.ss.Lookup(itemId).subscribe(response=>{
  this.searchRes = response.items;
  console.log(response);
//    this.Product.splice(0, this.Product.length);

  })
})
  //this.Product.splice(0, this.Product.length);
this.route.params.map(params => params['itemId']).subscribe((itemId) =>
{
/*
  this.ss.Recommend(itemId).subscribe(response=>{
  this.searchRec = response;

});
*/
});

}
}
