import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { EstampillaConsultaComponent } from './Estampilla/estampilla-consulta/estampilla-consulta.component';
import { EstampillaRegistroComponent } from './Estampilla/estampilla-registro/estampilla-registro.component';
import { AppRoutingModule } from './app-routing.module';
import { EstampillaService } from './services/estampilla.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    EstampillaConsultaComponent,
    EstampillaRegistroComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      
    ]),
    AppRoutingModule
  ],
  providers: [EstampillaService],
  bootstrap: [AppComponent]
})
export class AppModule { }
