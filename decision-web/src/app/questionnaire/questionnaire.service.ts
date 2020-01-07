import { HttpClient } from '@angular/common/http';
import { QuestionModel } from './questionnaire.component';
import { map } from 'rxjs/operators';
import { Injectable } from '@angular/core';

@Injectable()
export class QuestionnaireService {

  constructor(private http: HttpClient) { }

  getQuestionnaireList() {
    return this.http.get('https://localhost:5001/api/adventures').pipe(map((data: QuestionModel) => { return data; }));
  }
}
