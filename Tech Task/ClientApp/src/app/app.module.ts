import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { OrdersComponent, NewOrderComponent, OrderListComponent } from './orders/orders.component';
import { ProductsComponent } from './products/products.component';
import { CustomersComponent } from './customers/customers.component';

import { ProductService } from './_services/product.service';
import { OrderService } from './_services/order.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    OrdersComponent,
    NewOrderComponent,
    OrderListComponent,
    ProductsComponent,
    CustomersComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      {
        path: '',
        redirectTo: '/orders/list',
        pathMatch: 'full'
      },
      {
        path: 'orders',
        component: OrdersComponent,
        children: [
          { path: 'list', component: OrderListComponent },
          { path: 'new', component: NewOrderComponent }
        ]
      },
      { path: 'products', component: ProductsComponent },
      { path: 'customers', component: CustomersComponent },
    ])
  ],
  providers: [ProductService, OrderService],
  bootstrap: [AppComponent]
})
export class AppModule { }
