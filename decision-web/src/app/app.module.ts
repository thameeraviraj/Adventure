import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { QuestionnaireComponent } from './questionnaire/questionnaire.component';
import { QuestionnaireService } from './questionnaire/questionnaire.service';

@NgModule({
  declarations: [
    AppComponent,
    QuestionnaireComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [QuestionnaireService],
  bootstrap: [AppComponent]
})
export class AppModule { }
