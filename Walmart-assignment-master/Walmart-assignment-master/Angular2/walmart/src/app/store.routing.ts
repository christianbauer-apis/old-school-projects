import { Routes, RouterModule } from '@angular/router';
import {ModuleWithProviders} from '@angular/core'
import {ErrorComponent} from './error.component';

import {SearchResultsComponent} from './search-results/search-results.component';


const ROUTER:Routes = [
//  {path: '', component:  HeaderComponent},
  {path: 'results/:itemId', component: SearchResultsComponent},
  {path:'error', component: ErrorComponent }
]

export const storeRouting:ModuleWithProviders = RouterModule.forRoot(ROUTER)
