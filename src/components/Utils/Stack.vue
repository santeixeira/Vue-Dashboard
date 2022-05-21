<template>
  <ul class="ks-cboxtags">
    <li>
      <input type="checkbox" id="backend" value="backend" /><label for="backend"
        >Back-End</label
      >
    </li>
    <li>
      <input type="checkbox" id="frontend" value="frontend" /><label
        for="frontend"
        >Front-End</label
      >
    </li>
    <li>
      <input type="checkbox" id="mobile" value="mobile" /><label for="mobile"
        >Mobile</label
      >
    </li>
    <li>
      <input type="checkbox" id="devops" value="devops" /><label for="devops"
        >DevOps</label
      >
    </li>
    <li>
      <input type="checkbox" id="datascience" value="datascience" /><label
        for="datascience"
        >Data Science</label
      >
    </li>
  </ul>
</template>

<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "Stack",
  emits: ["addingTag"],
  data() {
    return {
      // tags: [] as tags[],
      tags: ["Node.js", "Python", "React.js"],
    };
  },
  methods: {
    addTag(): void {
      this.$emit("addingTag", {
        descricao: this.$data.tags,
      });
    },
    removeTag(index: number) {
      this.tags.splice(index, 1);
    },
  },
});
</script>
<style scoped lang="scss">
ul.ks-cboxtags li {
  display: inline;
}
ul.ks-cboxtags li label {
  display: inline-block;
  background-color: rgba(139, 139, 139, 0.3);
  border: none;
  color: #adadad;
  border-radius: 6px;
  margin: 3px 3px 3px;
  -webkit-touch-callout: none;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
  -webkit-tap-highlight-color: transparent;
  transition: all 0.2s;
  font-size: small;
}

ul.ks-cboxtags li label {
  padding: 2px 8px;
  cursor: pointer;
}

ul.ks-cboxtags li input[type="checkbox"]:checked + label {
  background-color: #e84616;
  color: #fff;
  transition: all 0.2s;

  #datascience:checked {
    background-color: #fff;
  }
}

ul.ks-cboxtags li input[type="checkbox"] {
  display: absolute;
}
ul.ks-cboxtags li input[type="checkbox"] {
  position: absolute;
  opacity: 0;
}
</style>
