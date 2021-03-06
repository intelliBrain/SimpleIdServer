import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ListOauthClientsComponent } from './list/list.component';
import { OAuthClientRoutes } from './oauthclients.routes';
import { MaterialModule } from '../../shared/material.module';
import { SharedModule} from '../../shared/shared.module';
import { TranslateEnumPipe } from '../../pipes/translateenum.pipe';
import { AvatarModule } from 'ngx-avatar';
import { FormTranslationComponent } from '../../common/components/formtranslation/formtranslation.component';
import { FormListComponent } from '../../common/components/formlist/formlist.component';
import { SelectorComponent } from '../../common/components/selector/selector.component';
import { ViewOauthClientsComponent } from './view/view.component';

@NgModule({
    imports: [
        AvatarModule,
        OAuthClientRoutes,
        CommonModule,
        SharedModule,
        MaterialModule
    ],
    entryComponents: [],
    declarations: [ ListOauthClientsComponent, FormTranslationComponent, ViewOauthClientsComponent, FormListComponent, SelectorComponent, TranslateEnumPipe ],
    providers: [ ]
})

export class OauthClientsModule { }