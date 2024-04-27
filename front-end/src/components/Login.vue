<script setup lang="ts">
    import Button from 'primevue/button';
    import Card from "primevue/card";
    import InputText from 'primevue/inputtext';

    import { ref } from 'vue';
    import { Login } from '../models/fields';

    const email = ref("");
    const password = ref("");
    const loginFields = ref<Login>({
        emailAddress: { required: true,
            name: "emailAddress"
         }, 
        password: { required: true,
            name: "password"
         }});

    const field = document.getElementById("field-data");
    if (field) {
        loginFields.value = JSON.parse(field.innerHTML);
        field.remove();
    }
</script>
<template>
    <Card>
        <template #content>
            <div class="field">
                <label  :for="loginFields.emailAddress.name" 
                        class="label mr-2">
                    Email Address</label>
                <InputText  :name="loginFields.emailAddress.name"
                            :id="loginFields.emailAddress.name"
                            class="w-full" 
                            v-model="email" />
            </div>
            <div class="field">
                <label  :for="loginFields.password.name"
                        class="label mr-2">Password</label>
                <InputText  :name="loginFields.password.name"
                            :id="loginFields.password.name"
                            class="w-full"
                            v-model="password" />
            </div>
        </template>
        <template #footer>
            <div class="flex flex-auto justify-content-center">
            <Button label="Login" class="mr-2" />
            <Button label="Register" />
            </div>
        </template>
    </Card>
</template>

<style lang="scss" scoped>
    div.field {
        label.label {
            text-align: right;
            &::after {
                content: ":";
            }
        }
    }
</style>