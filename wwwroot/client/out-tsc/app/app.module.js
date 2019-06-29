import * as tslib_1 from "tslib";
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { Landing } from './landing.component';
import { RouterModule } from '@angular/router';
let routes = [
    { path: '', component: Landing }
];
let AppModule = class AppModule {
};
AppModule = tslib_1.__decorate([
    NgModule({
        declarations: [
            AppComponent,
            Landing
        ],
        imports: [
            BrowserModule,
            RouterModule.forRoot(routes, {
                useHash: true,
                enableTracing: false // enable for debug
            })
        ],
        providers: [],
        bootstrap: [AppComponent]
    })
], AppModule);
export { AppModule };
//# sourceMappingURL=app.module.js.map