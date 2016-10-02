import { inject } from 'aurelia-framework';
import { HttpClient } from 'aurelia-fetch-client';

@inject(HttpClient)
export class Greeter {

    private greetingMessageViaApi : string;

    constructor(private httpClient: HttpClient, private message: string) {
    }

    async activate(): Promise < void> {
        this.httpClient.configure((config: any) => {
            config
                .useStandardConfiguration()
                .withBaseUrl("http://localhost:5000/api/")
        });       
        
        const http = this.httpClient;
        const response = await http.fetch("greetings");
        this.greetingMessageViaApi = await response.json();
    }

    sayHello() {
        console.log(`Hello ${this.message} from TypeScript!`);
    }

    get greetingMessage(): string {
        return `Hello ${this.message} from TypeScript!`;
    }
}
