import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { MenuComponent } from './menu/menu.component';
import { HeaderSectionComponent } from './header-section/header-section.component';
import { AboutUsComponent } from './about-us/about-us.component';
import { ChartSectionComponent } from './chart-section/chart-section.component';
import { PortfolioComponent } from './portfolio/portfolio.component';
import { ServicesSectionComponent } from './services-section/services-section.component';
import { FunFactsComponent } from './fun-facts/fun-facts.component';
import { OurClientsComponent } from './our-clients/our-clients.component';

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    HeaderSectionComponent,
    AboutUsComponent,
    ChartSectionComponent,
    PortfolioComponent,
    ServicesSectionComponent,
    FunFactsComponent,
    OurClientsComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
