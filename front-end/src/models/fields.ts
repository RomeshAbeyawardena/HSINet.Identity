export interface IField {
    name?: string;
    label?: string;
    type?: string;
    required: boolean;
    value?: any;
    error?: string;
    options?: string[];
}

export interface Login {
    emailAddress:IField;
    password:IField;
}

export interface Register {
    emailAddress:IField;
    password:IField;
    confirmPassword:IField;
    displayName:IField;
    crmReference:IField;
}

export interface Fields {
    login:Login;
}