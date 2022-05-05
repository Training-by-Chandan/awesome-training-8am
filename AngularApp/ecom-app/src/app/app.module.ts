import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { CreateComponent } from './Category/create/create.component';
import { IndexComponent } from './Category/index/index.component';
import { ButtonComponent } from './comp/button/button.component';
import { CardComponent } from './comp/card/card.component';
import { HeaderComponent } from './comp/header/header.component';
import { SidebarComponent } from './comp/sidebar/sidebar.component';


@NgModule({
  declarations: [
    AppComponent,
    ButtonComponent,
    CardComponent,
    HeaderComponent,
    SidebarComponent,
    IndexComponent,
    CreateComponent
  ],
  imports: [
    BrowserModule, 
    HttpClientModule, FormsModule, ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
