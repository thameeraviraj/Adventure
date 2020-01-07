import { Component, OnInit } from '@angular/core';
import { QuestionnaireService } from './questionnaire.service';

@Component({
  selector: 'app-questionnaire',
  templateUrl: './questionnaire.component.html',
  styleUrls: ['./questionnaire.component.scss']
})
export class QuestionnaireComponent implements OnInit {
  
  questionList = [];

  constructor(private questionnaireService: QuestionnaireService) { }

  ngOnInit() {
    this.getQuestionList();
  }


  getQuestionList() {
    this.questionnaireService.getQuestionnaireList().subscribe(res => {
      //console.log(res);
      this.questionList.push(res);
    }, error => {
      console.log(error)
    });
  }

  clickedAnswer(answer) {
    this.questionList.push(answer);
   // console.log('this.questionList', this.questionList)
  }
}


export class QuestionModel {
  value: string;
  isQuestion: boolean;
  isSelected: boolean;
  linkedNodes: []
}
