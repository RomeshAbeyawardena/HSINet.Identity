export interface IField {
    name?: string;
    label?: string;
    type?: string;
    required: boolean;
    value?: any;
    error?: string;
    options?: string[];
}

export interface IForm {
    formAction?:string;
    formMethod?:string;
}

export interface Login extends IForm {
    emailAddress:IField;
    password:IField;
}

export interface Register extends IForm {
    emailAddress:IField;
    password:IField;
    confirmPassword:IField;
    displayName:IField;
    crmReference:IField;
}

export interface Fields {
    login:Login;
    register:Register;
}