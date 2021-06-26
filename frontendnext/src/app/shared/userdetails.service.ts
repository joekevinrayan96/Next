import { Injectable } from '@angular/core';
import { HttpClient} from "@angular/common/http";
import { Userdetails } from './userdetails.model';

@Injectable({
  providedIn: 'root'
})
export class UserdetailsService {

  constructor(private http:HttpClient) { }

  readonly baseURL = 'http://localhost:14598/api/UserDetails'
  list : Userdetails[];

  refreshList(){
    this.http.get(this.baseURL)
    .toPromise()
    .then(res => this.list = res as Userdetails[]);
  }
}
