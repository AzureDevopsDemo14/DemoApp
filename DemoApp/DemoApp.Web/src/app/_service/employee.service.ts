import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { IEmployee } from '../model/employee';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class EmployeeService {

  // private headers: HttpHeaders;
  // private apiUrl = "https://localhost:44355/api/Employees";
  private url = "../assets/data/employees.json";

  constructor(private http: HttpClient) {
    // this.headers = new HttpHeaders({'Content-Type': 'application/json; charset=utf-8'});
   }

  // sendGetRequest() : Observable<Employees>  {
  //   console.log(this.apiUrl)
  //   return this.http.get<Employees>(this.apiUrl, {headers: this.headers});
  // }
  // sendGetRequest() : Observable<Employee[]> {
  //   console.log(this.apiUrl)
  //   return this.http.get<Employee[]>(this.apiUrl);
  //   // return this.http.get<Employee[]>(this.apiUrl, {headers:this.headers});
  // }
  getEmployees() : Observable<IEmployee[]> {
    console.log(this.http.get<IEmployee[]>(this.url))
    // console.log(this.url);
    return this.http.get<IEmployee[]>(this.url);
    // return this.http.get<Employee[]>(this.apiUrl, {headers:this.headers});
  }
}

