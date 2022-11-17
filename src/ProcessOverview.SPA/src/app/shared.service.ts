import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Process } from "src/process";

@Injectable({
  providedIn: 'root'
})
export class SharedService {
        readonly APIUrl = "http://localhost:44366/process";
    constructor(private http: HttpClient) {}
    getProcessOverview(): Observable < Process[] > {
        var a = this.http.get <Process[]> (this.APIUrl);
        console.log(a);
        return a;
    }
}