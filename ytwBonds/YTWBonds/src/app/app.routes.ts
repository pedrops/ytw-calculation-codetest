import { Routes } from '@angular/router';
import { BondSearchComponent } from './bond-search/bond-search.component';

export const routes: Routes = [
    {
        path:"",
        redirectTo: "ytw",
        pathMatch: "full"
    },
    {
    path: "ytw", 
    component: BondSearchComponent
}];
