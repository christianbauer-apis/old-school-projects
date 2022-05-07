import { BrowserModule } from '@angular/platform-browser';
import { HTMLEscapeUnescapeModule } from 'html-escape-unescape';
import { StickyNavModule } from 'ng2-sticky-nav';
import { NgModule } from '@angular/core';
import {JsonpModule} from '@angular/http';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';

import {storeRouting} from './store.routing';
import {ErrorComponent} from './error.component';

import { SearchResultsComponent } from './search-results/search-results.component';

import {StoreService} from './store.service';

@NgModule({
  declarations: [AppComponent, SearchResultsComponent, ErrorComponent],
  imports: [ BrowserModule, StickyNavModule, FormsModule, HTMLEscapeUnescapeModule, storeRouting, JsonpModule ],
  providers: [StoreService],
  bootstrap: [AppComponent]
})
export class AppModule { }
