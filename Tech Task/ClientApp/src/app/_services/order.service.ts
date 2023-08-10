import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Order, OrderResult } from '../_models/Order';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class OrderService {
  private baseUrl: string = environment.baseUrl + 'api/';
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }
  constructor(private http: HttpClient) { }

  public addOrder(order: Order) {
    return this.http.post(this.baseUrl + 'Orders', order, this.httpOptions);
  }

  public getOrders(): Observable<OrderResult[]> {
    return this.http.get<OrderResult[]>(this.baseUrl + `Orders`);
  }
}
