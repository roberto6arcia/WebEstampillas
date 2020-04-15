import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RouterModule, Routes } from '@angular/router';
import { EstampillaConsultaComponent } from './Estampilla/estampilla-consulta/estampilla-consulta.component';
import { EstampillaRegistroComponent } from './Estampilla/estampilla-registro/estampilla-registro.component';

const routes: Routes = [
  {
  path: 'estampillaConsulta',
  component: EstampillaConsultaComponent
  },
  {
    path: 'estampillaRegistro',
    component: EstampillaRegistroComponent
  }
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }
