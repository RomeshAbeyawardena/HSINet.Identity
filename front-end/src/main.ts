import { createApp } from 'vue'
import PrimeVue from 'primevue/config';
import App from './App.vue';
import "./assets/themes/basic.css";
import "primeflex/primeflex.scss";

const field = document.getElementById("data-field");

createApp(App)
    .use(PrimeVue, {
        unstyled: true
    }).mount('#app');
