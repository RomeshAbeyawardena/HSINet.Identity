<script setup lang="ts">
    import InputText from 'primevue/inputtext';

    import { ref } from 'vue';

    const email = ref("");
    const password = ref("");
    
    const field = document.getElementById("field-data");
    if (field) {
        const data = JSON.parse(field.innerHTML);
        field.remove();
    }


</script>
<template>
    <div class="field">
        <label class="label mr-2">Email Address</label>
        <InputText v-model="email" />
    </div>
    <div class="field">
        <label class="label mr-2">Password</label>
        <InputText v-model="password" />
    </div>
</template>

<style lang="scss" scoped>
    div.field {
        label.label {
            width: 100px;
            text-align: right;
        }
    }
</style>