import { Component } from '@angular/core';
import { Bond, Ytw } from './bond-search.model';
import { FormsModule } from '@angular/forms';
import { BondSearchService } from '../services/bond-search.service';
import { HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-bond-search',
  standalone: true,
  imports: [FormsModule, HttpClientModule],
  templateUrl: './bond-search.component.html',
  styleUrl: './bond-search.component.css'
})
export class BondSearchComponent {

  bond!: Bond
  ytw!: Ytw
  filteredBonds: Bond[] = [];
  searchQuery: string = '';
  calculatedYtw!: number;

  constructor(private bondSearchService: BondSearchService) { 

  }

  ngOnInit(): void {    
  }

  search(): void {
    this.bondSearchService.getBond(this.searchQuery.toLowerCase()).subscribe((resp) => {
      console.log(resp);
      const bond: Bond = { 
        name : resp.name,
        bondType : resp.bondType,
        couponRate : resp.couponRate,
        couponType : resp.couponType,
        faceValue : resp.faceValue,
        maturityDate : resp.maturityDate
      }
      this.bond =bond;
    })
  }

  calculateJWT(): void {
    this.bondSearchService.postBond(this.bond).subscribe((resp) => {
      const ytwResp: Ytw = {
        calculatedYtw : resp.calculatedYtw
      }
      this.ytw = ytwResp;
    });
  }
}
