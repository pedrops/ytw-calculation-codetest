import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Bond, Ytw } from '../bond-search/bond-search.model';

@Injectable({
  providedIn: 'root'
})
export class BondSearchService {

  private readonly baseUrl = 'https://localhost:7240'; 

  constructor(private http: HttpClient) { }

  getBond(searchQuery: string): Observable<Bond> {
    const url = `${this.baseUrl}/Bonds?bondName=${searchQuery}`;
    return this.http.get<Bond>(url);
  }

  postBond(bond: Bond): Observable<Ytw> {
    const url = `${this.baseUrl}/Bonds`;
    return this.http.post<Ytw>(url, bond);
  }
}
