
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { DemoComponent } from './demo/demo.component';
import { DirectivesComponent } from './directives/directives.component';
import { HttpClientModule } from '@angular/common/http';
// import { DirectivesComponent } from './directives/directives.component';

@Component({

  selector: 'app-root',
  standalone: true,
  imports: [DemoComponent, DirectivesComponent, RouterOutlet,HttpClientModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  CollegeName = 'LDCE';
  // isadmin = true;
  isdisable = false;

  onClick() {
    console.log('button clicked');
  }
  
  // title = 'LDCE';
}