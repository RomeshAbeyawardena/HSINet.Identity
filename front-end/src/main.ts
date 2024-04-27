import { createApp } from 'vue'
import PrimeVue from 'primevue/config';
import App from './App.vue';
import "./assets/themes/basic.css";
import "primeflex/primeflex.scss";
import "primevue/resources/themes/aura-dark-green/theme.css";
createApp(App)
    .use(PrimeVue, {
        
    }).mount('#app');
