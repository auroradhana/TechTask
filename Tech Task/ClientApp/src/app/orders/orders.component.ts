import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { DatePipe } from '@angular/common';
import { OrderService } from 'src/app/_services/order.service';
import { ProductService } from 'src/app/_services/product.service';
import { Order } from '../_models/Order';

@Component({
  template: `<router-outlet></router-outlet>`,
})
export class OrdersComponent {
}

@Component({
  templateUrl: './order-list.component.html',
  styleUrls: ['./orders.component.css']
})
export class OrderListComponent implements OnInit {
  orders: any;
  constructor(private router: Router,
    private service: OrderService) { }

  ngOnInit(): void {
    this.getOrders();
  }

  private getOrders() {
    this.service.getOrders().subscribe(orders => {
      this.orders = orders;
    });
  }
}


@Component({
  templateUrl: './new-order.component.html',
  styleUrls: ['./orders.component.css'],
  providers: [DatePipe]
})
export class NewOrderComponent {
  orderForm: any;
  orderAdd: Order = new Order;
  currentDate = new Date();
  products: Array<{ id: number, name: string, category: string, size: number, quantity: number, price: number }> = [];
  total: string;
  currFormater = new Intl.NumberFormat('en-US', {
    style: 'currency',
    currency: 'USD',
  });

  constructor(private router: Router,
      private oService: OrderService,
      private pService: ProductService,
      private formBuilder: FormBuilder) {
    this.CreateForm();
    this.total = this.currFormater.format(this.getTotal());
  }
  CreateForm() {
    this.orderForm = this.formBuilder.group({
      'id': ['', [Validators.required]],
      'customerId': ['', [Validators.required]],
      'orderDate': [this.currentDate.toLocaleDateString()],
      'status': ['', [Validators.required]],
      'products': [this.products],
      'comment': [''],
      'totalCost': ['']
    });
  }

  addProduct(): void {
    //test
    this.products.push(
      { id: 1, name: "First", category: "Test", size: 5, quantity: 2, price: 50 }
    );
    this.total = this.currFormater.format(this.getTotal());
  }

  saveOrder(): void {
    this.orderAdd.orderNumber = Number(this.orderForm.value['id']); 
    this.orderAdd.customerId = Number(this.orderForm.value['customerId']);
    this.orderAdd.orderDate = new Date(this.orderForm.value['orderDate']);
    this.orderAdd.status = this.orderForm.value['status'];
    this.orderAdd.products = [];
    this.orderAdd.comment = this.orderForm.value['comment'];
    //console.log(this.orderAdd);
    this.oService.addOrder(this.orderAdd).subscribe(() => {
      this.router.navigate(['/orders/list']);
    });
  }

  getTotal(): number {
    let total = 0;
    for (const element of this.products) {
      total += element.quantity * element.price;
    }
    return total;
  }
}

